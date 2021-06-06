import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

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

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    alert();
  }
}
