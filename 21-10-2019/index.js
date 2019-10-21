"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var words = ['coding blast', 'coding', 'blast'];
var source = rxjs_1.Observable.from(words);
function next(value) {
    console.log('next: ', value);
}
function error(err) {
    console.log('error: ', err);
}
function complete() {
    console.log('complete');
}
