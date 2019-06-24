import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';
import { maritalStatuses, educations } from 'src/app/model/constants';

@Component({
  selector: 'bs-bio-data',
  templateUrl: './bio-data.component.html',
  styleUrls: ['./bio-data.component.css']
})
export class BioDataComponent implements OnInit {
  form: FormGroup;
  marts = maritalStatuses;

  educs = educations;
  constructor(fb: FormBuilder, meta: Meta, title: Title, data: DataProvider) {
    meta.addTags([{ name: 'description', content: "Page for data entry" }]);
    title.setTitle("Data Entry");
    this.form = fb.group({
      isSelf: ['', Validators.compose([Validators.required])],
      age: ['', Validators.compose([Validators.required])],
      marital: ['', Validators.compose([Validators.required])],
      religion: ['', Validators.compose([Validators.required])],
      ethnicity: ['', Validators.compose([Validators.required])],
      education: ['', Validators.compose([Validators.required])]
    })
  }

  ngOnInit() {
  }

}
