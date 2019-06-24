import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';

@Component({
  selector: 'bs-bio-data',
  templateUrl: './bio-data.component.html',
  styleUrls: ['./bio-data.component.css']
})
export class BioDataComponent implements OnInit {

  constructor(fb: FormBuilder, meta: Meta, title: Title, data:DataProvider) {
    meta.addTags([{ name: 'description', content: "Page for data entry" }]);
    title.setTitle("Data Entry");

  }

  ngOnInit() {
  }

}
