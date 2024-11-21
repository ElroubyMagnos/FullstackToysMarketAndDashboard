import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'decimalfixer'
})
export class DecimalfixerPipe implements PipeTransform {

  transform(value: number, ...args: unknown[]): string {
    var TheString = value.toString();

    if (TheString.includes('.'))
    {
      var Splitted = TheString.split('.');

      return Splitted[0] + '.' + Splitted[1][0];
    }
    else return TheString;
  }

}
