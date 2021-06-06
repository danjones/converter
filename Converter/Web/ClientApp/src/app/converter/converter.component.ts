import { DecimalPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ConverterService } from './converter.service';
import { UnitOfTemperature } from './unit-of-temperature';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.scss']
})
export class ConverterComponent implements OnInit {
  unitsOfTemperature: UnitOfTemperature[] = [];
  resultString?: string = undefined;
  convertForm = new FormGroup({
    value: new FormControl('', Validators.required),
    fromId: new FormControl('', Validators.required),
    toId: new FormControl('', Validators.required)
  });

  constructor(private converterService: ConverterService, private decimalPipe: DecimalPipe) { }

  ngOnInit(): void {
    this.converterService.getUnitsOfTemperature()
      .subscribe((data) => this.unitsOfTemperature = data);
  }

  onSubmit(): void {
    if (this.convertForm.valid) {
      this.converterService.getConversion(this.convertValue, this.fromUnitId, this.toUnitId)
        .subscribe((result) => {
          // Build results string based on selected units and value
          const fromUnit = this.unitsOfTemperature.find(x => x.id === this.fromUnitId);
          const toUnit = this.unitsOfTemperature.find(x => x.id === this.toUnitId);
          this.resultString = `${this.convertValue} ${fromUnit?.name} = ${this.decimalPipe.transform(result)} ${toUnit?.name}`;
        });
    } else {
      this.convertForm.markAllAsTouched();
    }
  }

  get fromUnitId(): number {
    return +this.convertForm.get('fromId')?.value;
  }
  get toUnitId(): number {
    return +this.convertForm.get('toId')?.value;
  }
  get convertValue(): number {
    return +this.convertForm.get('value')?.value;
  }
}
