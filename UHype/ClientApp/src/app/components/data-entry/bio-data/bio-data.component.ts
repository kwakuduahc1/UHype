import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { DataProvider } from 'src/app/providers/DataProvider';
import { maritalStatuses, educations, religions, energies, occupation, gender, ethnics, sections, tripples, yesNos, knows, drugSrcs, twoYearsCare, limits, yearCompare, healthScale, actLimits, phyLimits, emLimits, levels, eae, healthies, heaqts } from 'src/app/model/constants';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { IDemography, ISecondSections, IQualityAssessments } from 'src/app/model/dtos';

@Component({
  selector: 'bs-bio-data',
  templateUrl: './bio-data.component.html',
  styleUrls: ['./bio-data.component.css']
})
export class BioDataComponent implements OnInit {
  form: FormGroup;
  form2: FormGroup;
  form3: FormGroup;
  form4: FormGroup;
  antform: FormGroup;
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
  cares = twoYearsCare;
  limits = limits;
  cps = yearCompare;
  scales = healthScale;
  actLimits = actLimits;
  phyLimits = phyLimits;
  emLimits = emLimits;
  levels = levels;
  eae = eae;
  energies = energies;
  healthies = healthies;
  heaqts = heaqts;
  constructor(fb: FormBuilder, meta: Meta, title: Title, private data: DataProvider, public act: ActivityProvider) {
    meta.addTags([{ name: 'description', content: "Page for data entry" }]);
    title.setTitle("Data Entry");
    this.form = fb.group({
      isSelf: [false, Validators.compose([Validators.required])],
      age: [35, Validators.compose([Validators.required, Validators.min(10), Validators.max(120)])],
      gender: [0, Validators.compose([Validators.required, Validators.min(0), Validators.max(1)])],
      marital: [1, Validators.compose([Validators.required])],
      religion: [5, Validators.compose([Validators.required])],
      ethnicity: [2, Validators.compose([Validators.required])],
      education: [2, Validators.compose([Validators.required])],
      occupation: [1, Validators.compose([Validators.required])]
    });
    this.form2 = fb.group({
      hasPressure: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      screening: [2, Validators.compose([Validators.required])],
      others: ["None", Validators.compose([Validators.minLength(3), Validators.maxLength(50)])],
      isControlled: [1, Validators.compose([Validators.required])],
      hasAdmittedIn12: [1, Validators.compose([Validators.required])],
      measureAtHome: [true, Validators.compose([Validators.required])],
      relativesHBP: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      degree1: [1, Validators.compose([Validators.required])],
      chronicDisease: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
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
      othersCND: [1, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])],
      hPTMeds: [1, Validators.compose([Validators.min(1), Validators.max(3)])],
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
      otherMeds: ["", Validators.compose([Validators.minLength(3), Validators.maxLength(50)])],
      hospitalNHIS: [true, Validators.compose([Validators.required])],
      hospClosePharmNHIS: [true, Validators.compose([Validators.required])],
      hospClosePharmLater: [true, Validators.compose([Validators.required])],
      closePharmNHIS: [true, Validators.compose([Validators.required])],
      hospitalFee: [true, Validators.compose([Validators.required])],
      labWork: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      hasNHIS: [true, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      careFacilities: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      doGetMedsFromAll: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      hasSpecialClinic: [true, Validators.compose([Validators.required, Validators.min(1), Validators.max(3)])],
      sameDoctor: [3, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      drTellState: [4, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      staffAdvise: [2, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      runOutMeds: [2, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      missAppointment: [2, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      takeDrugsBeforeVisit: [1, Validators.compose([Validators.required, Validators.min(1), Validators.max(4)])],
      hospTime: [2, Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])]
    })
    this.form3 = fb.group({
      financeDiffs: ["", Validators.compose([Validators.required])],
      hasConcerns: ["", Validators.compose([Validators.required])],
      concerns: ["", Validators.compose([Validators.required])],
      hasAssitance: ["", Validators.compose([Validators.required])],
      takesHerbal: ["", Validators.compose([Validators.required])],
      stillHerbal: ["", Validators.compose([Validators.required])],
      herbReason: ['', Validators.compose([Validators.minLength(4), Validators.maxLength(100)])],
      seenDietician: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      believeDiet: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      specialDiet: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      physicalActivity: ["", Validators.compose([Validators.required])],
      walking: ["", Validators.compose([Validators.required])],
      running: ["", Validators.compose([Validators.required])],
      others: ["", Validators.compose([Validators.required])],
      oftenPhysical: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      timePhysical: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(6)])],
      cigarette: ["", Validators.compose([Validators.required])],
      howLongCig: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      numberPerDay: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      currentDrink: ["", Validators.compose([Validators.required])],
      everDrunk: ["", Validators.compose([Validators.required])],
      howLongAlc: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      unitsPerWeek: ["", Validators.compose([Validators.required, Validators.min(0), Validators.max(4)])],
      isRiskStroke: ["", Validators.compose([Validators.required])],
      isRiskHeartAttack: ["", Validators.compose([Validators.required])],
      isRiskDiabetes: ["", Validators.compose([Validators.required])],
      isRiskBlind: ["", Validators.compose([Validators.required])],
      isRiskKidney: ["", Validators.compose([Validators.required])],
      dieEarly: ["", Validators.compose([Validators.required])],
      feelSad: ["", Validators.compose([Validators.required])],
      doctorWish: ["", Validators.compose([Validators.required])],
    });
    this.form4 = fb.group({
      healthScale: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      compared: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      vigorous: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      moderate: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      climbing: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      bending: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      walkingMile: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      walkingBlocks: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      walkingOne: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      bathingSelf: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      cutDown: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      accomplishLess: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      wereLimited: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      hadDiff: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      cutDownEm: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      accomplishEm: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      wasCareful: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      emotionalInterfere: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      bodyPainsIn4: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      bodyPainInHouse: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      hasPed: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      isNervous: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      isDump: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      wasPeaceful: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      hasEnergy: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      wasDownhearted: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      wasWornOut: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      beenHappy: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      feelTired: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      socialInterfere: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      sickEasier: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      veryHealthy: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      toGetWorse: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
      isExcellent: ['', Validators.compose([Validators.required, Validators.min(1), Validators.max(6)])],
    });
    this.antform = fb.group(
      {
        demographyID: [false, Validators.compose([Validators.required])],
        height: ['', Validators.compose([Validators.required, Validators.min(40), Validators.max(200)])],
        weight: ['', Validators.compose([Validators.required, Validators.min(30), Validators.max(200)])],
        mUAC: ['', Validators.compose([Validators.required])],
        abdCirc: ['', Validators.compose([Validators.required])],
        systole: ['', Validators.compose([Validators.required, Validators.min(30), Validators.max(200)])],
        diastole: ['', Validators.compose([Validators.required, Validators.min(20), Validators.max(130)])],
        fat: ['', Validators.compose([Validators.required, Validators.min(10), Validators.max(90)])]
      })
  }

  ngOnInit() {
  }

  addDem(back: IDemography) {
    this.data.data.demography = back;
    this.sections.forEach(x => x.state = false);
    this.sections[1].state = true;
  }

  addSec2(sec: ISecondSections) {
    this.data.data.demography.secondSection = sec;
    this.sections.forEach(x => x.state = false);
    this.sections[2].state = true;
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

  add4(qsa: IQualityAssessments) {
    this.data.data.demography.qualityAssessments = qsa;
  }

  check(f: FormGroup) {
    console.log(f);
  }
}
