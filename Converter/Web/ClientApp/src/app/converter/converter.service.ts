import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ConverterService {
  private unitsOfTemperatureUrl = 'api/unitsoftemperature';
  private convertUrl = 'api/convert';

  constructor(private http: HttpClient) { }

  getUnitsOfTemperature(): any {
    return this.http.get<any>(this.unitsOfTemperatureUrl);
  }

  getConversion(value: number, fromUnitId: number, toUnitId: number) : void {
    alert("Test");
  }
}
