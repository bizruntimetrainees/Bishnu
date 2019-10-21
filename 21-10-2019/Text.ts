import { Observable } from 'rxjs';
 
const observable = new Observable(subscriber => {
  subscriber.next(10);
  subscriber.next(20);
  subscriber.next(30);
  setTimeout(() => {
    subscriber.next(40);
    subscriber.complete();
  }, 1000);
});
 
console.log('just before subscribe');
observable.subscribe({
  next(x) { console.log('got value ' + x); },
  error(err) { console.error('something wrong occurred: ' + err); },
  complete() { console.log('done'); }
});
console.log('just after subscribe');