import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';
import { maritalStatuses, educations, religions, energies, occupation, gender, Ethnics } from 'src/app/model/constants';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { IDemography } from 'src/app/model/dtos';
import { state } from '@angular/animations';

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
  eths = Ethnics;
  occs = occupation;
  educs = educations;
  gens = gender;
  sections: Array<{ section: number, state: boolean, label: string }> = [
    { section: 1, state: true, label: "Demographic Information" },
    { section: 2, state: false, label: "Hypertension, Co-morbidities and Medications" },
    { section: 3, state: false, label: "Social factors and beliefs" },
    { section: 4, state: false, label: "Health related quality assessment of life" },
    { section: 5, state: false, label: "Anthropometry" },
    { section: 7, state: false, label: "Labs and others" }
  ]
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
      visit: [false, Validators.compose([Validators.required])],
      pharmacy: [false, Validators.compose([Validators.required])],
      admission: [false, Validators.compose([Validators.required])],
      forgotten: [false, Validators.compose([Validators.required])],
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
      othersCND: [false, Validators.compose([Validators.required])],
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
}
