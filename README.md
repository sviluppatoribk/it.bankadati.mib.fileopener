# Cordova - Plugin per l'apertura di file con API di sistema per WP8, Android (v. 0.0.1)

## DESCRIZIONE

Questo plugin permette l'apertura di file salvati sullo storage del device con le API native di sistema.

### UTILIZZO
Una volta installato è possible richiamarlo con:

```js
var localFileUrl = '/path/to/file/file.ext';

window.plugins.mibFileOpener.openFile(function (success)
{
	console.log("Apertura del file " + localFileUrl + " Riuscita: " + JSON.stringify(success));
}, function (error) {
	console.log("Apertura del file " + localFileUrl + " KO: " + JSON.stringify(error));
},
localFileUrl);
```
