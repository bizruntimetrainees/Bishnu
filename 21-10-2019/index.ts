import { Observable } from 'rxjs';

let words = ['coding blast', 'coding', 'blast'];

let source = Observable.from(words);

function next(value: string) {
    console.log('next: ', value);
}

function error(err: any) {
    console.log('error: ', err);
}

function complete() {
    console.log('complete');
}

