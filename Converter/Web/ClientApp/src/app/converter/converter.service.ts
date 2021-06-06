import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { UnitOfTemperature } from './unit-of-temperature';

@Injectable({
  providedIn: 'root'
})
export class ConverterService {
  private unitsOfTemperatureUrl = 'api/unitsoftemperature';
  private convertUrl = 'api/convert';

  constructor(private http: HttpClient) { }

  getUnitsOfTemperature(): Observable<UnitOfTemperature[]> {
    return this.http.get<UnitOfTemperature[]>(this.unitsOfTemperatureUrl);
  }

  getConversion(value: number, fromUnitId: number, toUnitId: number) : Observable<number> {
    return this.http.get<number>(this.convertUrl);
  }
}
