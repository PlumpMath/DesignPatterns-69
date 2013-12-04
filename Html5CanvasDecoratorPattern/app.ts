interface IImageRender {
    context:CanvasRenderingContext2D;
    image:HTMLImageElement;
    render(canvas: HTMLCanvasElement, imageUrl:string);
    onImageLoad();
}

class ImageRender implements IImageRender{
    context: CanvasRenderingContext2D;
    image:HTMLImageElement;
    render(canvas:HTMLCanvasElement, imageUrl:string) {
        if (canvas.getContext) {
            this.context = canvas.getContext("2d");
            this.image = new Image(); // Create a new blank image.
            this.image.onload = () => {
                this.onImageLoad();
            }
            this.image.src = imageUrl;
            console.log("hi");
        }
    }
    onImageLoad() {
        this.context.drawImage(this.image, 0, 0);
    }
}

class AFilterImageRender implements IImageRender {
    context: CanvasRenderingContext2D;
    image: HTMLImageElement;
    private _imageRender: IImageRender;

    constructor(imageRender: IImageRender) {
        this._imageRender = imageRender;
    }

    render(canvas:HTMLCanvasElement, imageUrl:string) {
        if (canvas.getContext) {
            this._imageRender.render(canvas, imageUrl);
            this._imageRender.image.onload = () => {
                this.onImageLoad();
            }
        }
    }
    onImageLoad() {
        this._imageRender.onImageLoad();
        this._filter();
    }

    private _filter() {
        throw new Error('This method is abstract');
    }
}

class CircleFramedImageRender extends AFilterImageRender implements IImageRender {
    private _imageRender: IImageRender;

    //override filter method
    private _filter() {
        this._imageRender.context.strokeStyle = "#FF0000";
        this._imageRender.context.lineWidth = 100;
        this._imageRender.context.beginPath();
        this._imageRender.context.arc(100, 100, 150, 0, Math.PI * 2, true);
        this._imageRender.context.closePath();
        this._imageRender.context.stroke();
    }
}

class RectangleFrameImageRender extends AFilterImageRender implements IImageRender {
    private _imageRender: IImageRender;
    private _filter() {
        this._imageRender.context.strokeStyle = "#0000FF";
        this._imageRender.context.lineWidth = 50;
        this._imageRender.context.beginPath();
        this._imageRender.context.rect(0, 0, 200, 200);
        this._imageRender.context.closePath();
        this._imageRender.context.stroke();
    }
}

class InvertImageRender extends AFilterImageRender implements IImageRender {
    private _imageRender: IImageRender;

    //override filter method
    private _filter() {
        var imageData = this._imageRender.context.getImageData(0, 0, this._imageRender.image.width, this._imageRender.image.height);
        var data = imageData.data;
        console.log(data);

        for (var i = 0; i < data.length; i += 4) {
            // red
            data[i] = 255 - data[i];
            // green
            data[i + 1] = 255 - data[i + 1];
            // blue
            data[i + 2] = 255 - data[i + 2];
        }
        // overwrite original image
        this._imageRender.context.putImageData(imageData, 0, 0);
    }
}

//init app
window.onload = () => {
    var image = "images/sample.png";

    var imageRender = new ImageRender();
    imageRender.render(<HTMLCanvasElement>document.getElementById("myCanvas"), image);

    //decorator object circle frame
    var framedImageRender1 = new CircleFramedImageRender(new ImageRender());
    framedImageRender1.render(<HTMLCanvasElement>document.getElementById("myCanvasFramed1"), image);

    //decorator object rectangle frame
    var framedImageRender2 = new RectangleFrameImageRender(new ImageRender());
    framedImageRender2.render(<HTMLCanvasElement>document.getElementById("myCanvasFramed2"), image);

    //decorator object invert color
    var framedImageRender3 = new InvertImageRender(new ImageRender());
    framedImageRender3.render(<HTMLCanvasElement>document.getElementById("myCanvasFramed3"), image);

    
};