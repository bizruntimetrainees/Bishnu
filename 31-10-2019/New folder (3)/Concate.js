"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var timer1 = rxjs_1.interval(1000).pipe(operators_1.take(10));
var timer2 = rxjs_1.interval(500).pipe(operators_1.take(6));
var timer3 = rxjs_1.interval(800).pipe(operators_1.take(10));
var result = rxjs_1.concat(timer1, timer2, timer3);
result.subscribe(function (x) { return console.log(x); });
