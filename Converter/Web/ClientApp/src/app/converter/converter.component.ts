import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ConverterService } from './converter.service';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.scss']
})
export class ConverterComponent implements OnInit {
  convertForm = new FormGroup({
    value: new FormControl('', Validators.required),
    fromId: new FormControl('', Validators.required),
    toId: new FormControl('', Validators.required)
  });

  constructor(private converterService: ConverterService) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    if (this.convertForm.valid) {
      this.converterService.getConversion(
        this.convertForm.get('value')?.value,
        this.convertForm.get('fromId')?.value,
        this.convertForm.get('toId')?.value);
    } else {
      this.convertForm.markAllAsTouched();
    }
  }
}
