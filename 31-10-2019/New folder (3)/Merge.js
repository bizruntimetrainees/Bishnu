"use strict";
exports.__esModule = true;
var Observable_1 = require("rxjs/Observable");
var merge_1 = require("rxjs/observable/merge");
var observable = Observable_1.Observable.create(function (observer) {
    observer.next('Good Evening!');
});
var observable2 = Observable_1.Observable.create(function (observer) {
    observer.next('How is it going?');
});
var newObs = merge_1.merge(observable, observable2);
newObs.subscribe(function (x) { return addItem(x); });
function addItem(val) {
    var node = document.createElement("li");
    var textnode = document.createTextNode(val);
    node.appendChild(textnode);
    document.getElementById("output").appendChild(node);
}
