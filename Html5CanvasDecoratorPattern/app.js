var __extends = this.__extends || function (d, b) {
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var ImageRender = (function () {
    function ImageRender() { }
    ImageRender.prototype.render = function (canvas, imageUrl) {
        var _this = this;
        if(canvas.getContext) {
            this.context = canvas.getContext("2d");
            this.image = new Image();
            this.image.onload = function () {
                _this.onImageLoad();
            };
            this.image.src = imageUrl;
            console.log("hi");
        }
    };
    ImageRender.prototype.onImageLoad = function () {
        this.context.drawImage(this.image, 0, 0);
    };
    return ImageRender;
})();
var AFilterImageRender = (function () {
    function AFilterImageRender(imageRender) {
        this._imageRender = imageRender;
    }
    AFilterImageRender.prototype.render = function (canvas, imageUrl) {
        var _this = this;
        if(canvas.getContext) {
            this._imageRender.render(canvas, imageUrl);
            this._imageRender.image.onload = function () {
                _this.onImageLoad();
            };
        }
    };
    AFilterImageRender.prototype.onImageLoad = function () {
        this._imageRender.onImageLoad();
        this._filter();
    };
    AFilterImageRender.prototype._filter = function () {
        throw new Error('This method is abstract');
    };
    return AFilterImageRender;
})();
var CircleFramedImageRender = (function (_super) {
    __extends(CircleFramedImageRender, _super);
    function CircleFramedImageRender() {
        _super.apply(this, arguments);

    }
    CircleFramedImageRender.prototype._filter = function () {
        this._imageRender.context.strokeStyle = "#FF0000";
        this._imageRender.context.lineWidth = 100;
        this._imageRender.context.beginPath();
        this._imageRender.context.arc(100, 100, 150, 0, Math.PI * 2, true);
        this._imageRender.context.closePath();
        this._imageRender.context.stroke();
    };
    return CircleFramedImageRender;
})(AFilterImageRender);
var RectangleFrameImageRender = (function (_super) {
    __extends(RectangleFrameImageRender, _super);
    function RectangleFrameImageRender() {
        _super.apply(this, arguments);

    }
    RectangleFrameImageRender.prototype._filter = function () {
        this._imageRender.context.strokeStyle = "#0000FF";
        this._imageRender.context.lineWidth = 50;
        this._imageRender.context.beginPath();
        this._imageRender.context.rect(0, 0, 200, 200);
        this._imageRender.context.closePath();
        this._imageRender.context.stroke();
    };
    return RectangleFrameImageRender;
})(AFilterImageRender);
var InvertImageRender = (function (_super) {
    __extends(InvertImageRender, _super);
    function InvertImageRender() {
        _super.apply(this, arguments);

    }
    InvertImageRender.prototype._filter = function () {
        var imageData = this._imageRender.context.getImageData(0, 0, this._imageRender.image.width, this._imageRender.image.height);
        var data = imageData.data;
        console.log(data);
        for(var i = 0; i < data.length; i += 4) {
            data[i] = 255 - data[i];
            data[i + 1] = 255 - data[i + 1];
            data[i + 2] = 255 - data[i + 2];
        }
        this._imageRender.context.putImageData(imageData, 0, 0);
    };
    return InvertImageRender;
})(AFilterImageRender);
window.onload = function () {
    var image = "images/sample.png";
    var imageRender = new ImageRender();
    imageRender.render(document.getElementById("myCanvas"), image);
    var framedImageRender1 = new CircleFramedImageRender(new ImageRender());
    framedImageRender1.render(document.getElementById("myCanvasFramed1"), image);
    var framedImageRender2 = new RectangleFrameImageRender(new ImageRender());
    framedImageRender2.render(document.getElementById("myCanvasFramed2"), image);
    var framedImageRender3 = new InvertImageRender(new ImageRender());
    framedImageRender3.render(document.getElementById("myCanvasFramed3"), image);
};
