import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';
import { maritalStatuses, educations, religions, energies, occupation, gender } from 'src/app/model/constants';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { IDemography } from 'src/app/model/dtos';

@Component({
  selector: 'bs-bio-data',
  templateUrl: './bio-data.component.html',
  styleUrls: ['./bio-data.component.css']
})
export class BioDataComponent implements OnInit {
  form: FormGroup;
  marts = maritalStatuses;
  rels = religions;
  eths = energies;
  occs = occupation;
  educs = educations;
  gens = gender;
  constructor(fb: FormBuilder, meta: Meta, title: Title, private data: DataProvider, public act:ActivityProvider) {
    meta.addTags([{ name: 'description', content: "Page for data entry" }]);
    title.setTitle("Data Entry");
    this.form = fb.group({
      isSelf: [false, Validators.compose([Validators.required])],
      age: ['', Validators.compose([Validators.required, Validators.min(10), Validators.max(120)])],
      gender: ['', Validators.compose([Validators.required, Validators.min(0), Validators.max(1)])],
      marital: ['', Validators.compose([Validators.required])],
      religion: ['', Validators.compose([Validators.required])],
      ethnicity: ['', Validators.compose([Validators.required])],
      education: ['', Validators.compose([Validators.required])]
    })
  }

  ngOnInit() {
  }

  add(back: IDemography) {
    this.data.data.demography = back;
  }
}
