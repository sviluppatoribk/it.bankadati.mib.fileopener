var MibFileOpener = function() {
};

MibFileOpener.prototype.openFile = function (successCallback, errorCallback, fileUrl) {
    if (errorCallback == null) { errorCallback = function () { } }

    if (typeof errorCallback != "function") {
        console.log("MibFileOpener.fileOpen: failure parameter not a function");
        return
    }

    if (typeof successCallback != "function") {
        console.log("MibFileOpener.fileOpen: success callback parameter must be a function");
        return
    }

    cordova.exec(successCallback, errorCallback, "MibFileOpener", "openFile", [fileUrl]);
};

//-------------------------------------------------------------------

if(!window.plugins) {
    window.plugins = {};
}
if (!window.plugins.mibFileOpener) {
    window.plugins.mibFileOpener = new MibFileOpener();
}

if (typeof module != 'undefined' && module.exports) {
  module.exports = MibFileOpener;
}