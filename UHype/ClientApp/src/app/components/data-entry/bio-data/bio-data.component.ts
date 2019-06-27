import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';
import { maritalStatuses, educations, religions, energies, occupation, gender, ethnics, sections, tripples, yesNos, knows, drugSrcs } from 'src/app/model/constants';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { IDemography } from 'src/app/model/dtos';

@Component({
  selector: 'bs-bio-data',
  templateUrl: './bio-data.component.html',
  styleUrls: ['./bio-data.component.css']
})
export class BioDataComponent implements OnInit {
  form: FormGroup;
  form2: FormGroup;
  marts = maritalStatuses;
  rels = religions;
  eths = ethnics;
  occs = occupation;
  educs = educations;
  gens = gender;
  sections = sections;
  trips = tripples;
  bools = yesNos;
  knows = knows;
  srcs = drugSrcs;
  constructor(fb: FormBuilder, meta: Meta, title: Title, private data: DataProvider, public act: ActivityProvider) {
    meta.addTags([{ name: 'description', content: "Page for data entry" }]);
    title.setTitle("Data Entry");
    this.form = fb.group({
      isSelf: [false, Validators.compose([Validators.required])],
      age: ['', Validators.compose([Validators.required, Validators.min(10), Validators.max(120)])],
      gender: ['', Validators.compose([Validators.required, Validators.min(0), Validators.max(1)])],
      marital: ['', Validators.compose([Validators.required])],
      religion: ['', Validators.compose([Validators.required])],
      ethnicity: ['', Validators.compose([Validators.required])],
      education: ['', Validators.compose([Validators.required])],
      occupation: ['', Validators.compose([Validators.required])]
    });
    this.form2 = fb.group({
      hasPressure: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      screening: [false, Validators.compose([Validators.required])],
      others: ["", Validators.compose([Validators.minLength(3), Validators.maxLength(50)])],
      isControlled: [false, Validators.compose([Validators.required])],
      hasAdmittedIn12: [false, Validators.compose([Validators.required])],
      measureAtHome: [false, Validators.compose([Validators.required])],
      relativesHBP: [false, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      degree1: [false, Validators.compose([Validators.required])],
      chronicDisease: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      diabetes: [false, Validators.compose([Validators.required])],
      cKD: [false, Validators.compose([Validators.required])],
      heartFail: [false, Validators.compose([Validators.required])],
      stroke: [false, Validators.compose([Validators.required])],
      dementia: [false, Validators.compose([Validators.required])],
      atrialFib: [false, Validators.compose([Validators.required])],
      prostate: [false, Validators.compose([Validators.required])],
      cAD: [false, Validators.compose([Validators.required])],
      hyperLip: [false, Validators.compose([Validators.required])],
      pain: [false, Validators.compose([Validators.required])],
      othersCND: [, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])],
      hPTMeds: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      amlodipine: [false, Validators.compose([Validators.required])],
      lisinopril: [false, Validators.compose([Validators.required])],
      losarta: [false, Validators.compose([Validators.required])],
      bendro: [false, Validators.compose([Validators.required])],
      hCTZ: [false, Validators.compose([Validators.required])],
      atenolol: [false, Validators.compose([Validators.required])],
      bisoprolol: [false, Validators.compose([Validators.required])],
      methlydopa: [false, Validators.compose([Validators.required])],
      frusemide: [false, Validators.compose([Validators.required])],
      hydralazine: [false, Validators.compose([Validators.required])],
      otherMeds: [false, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])],
      hospitalNHIS: [false, Validators.compose([Validators.required])],
      hospClosePharmNHIS: [false, Validators.compose([Validators.required])],
      hospClosePharmLater: [false, Validators.compose([Validators.required])],
      closePharmNHIS: [false, Validators.compose([Validators.required])],
      hospitalFee: [false, Validators.compose([Validators.required])],
      labWork: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      hasNHIS: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      careFacilities: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      doGetMedsFromAll: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      hasSpecialClinic: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      sameDoctor: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      drTellState: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      staffAdvise: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      runOutMeds: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      missAppointment: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      takeDrugsBeforeVisit: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      hospTime: ["", Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])]
    })
  }

  ngOnInit() {
  }

  addDem(back: IDemography) {
    this.data.data.demography = back;
    this.sections.forEach(x => x.state = false);
    this.sections[1].state = true;
  }


  prev(ix: number) {
    this.sections.forEach(x => x.state = false);
    this.sections[ix - 1].state = true;
  }

  showKnowOther = false;
  changeKnow(ix: number) {
    if (ix === 5)
      this.showKnowOther = true;
    else this.showKnowOther = false;
  }
}
