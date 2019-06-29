export interface IDemography {
  demographyID: number;
  isSelf: number;
  facility: string;
  age: string;
  gender: number;
  marital: string;
  religion: string;
  ethnicity: string;
  occupation: string;
  education: string;
  dateAdded: Date;
  secondSection: ISecondSections;
  anthropometries: IAnthropometries;
  bpHistory: IBpHistory;
  charts: ICharts;
  labs: ILabs;
  qualityAssessments: IQualityAssessments;
  SocioFactors: ISocioFactors;
}
export interface ISecondSections {
  demographyID: number;
  hasPressure: number;
  screening: boolean;
  visit: boolean;
  pharmacy: boolean;
  admission: boolean;
  forgotten: boolean;
  others: string;
  isControlled: boolean;
  hasAdmitedIn12: boolean;
  measureAtHome: boolean;
  relativesHBP: number;
  degree1: boolean;
  chronicDisease: number;
  diabetes: boolean;
  cKD: boolean;
  heartFail: boolean;
  stroke: boolean;
  dementia: boolean;
  atrialFib: boolean;
  prostate: boolean;
  cAD: boolean;
  hyperLip: boolean;
  pain: boolean;
  othersCND: string;
  hPTMeds: number;
  amlodipine: boolean;
  lisinopril: boolean;
  losarta: boolean;
  bendro: boolean;
  hCTZ: boolean;
  atenolol: boolean;
  bisoprolol: boolean;
  methlydopa: boolean;
  frusemide: boolean;
  hydralazine: boolean;
  otherMeds: string;
  hospitalNHIS: boolean;
  hospClosePharmNHIS: boolean;
  hospClosePharmLater: boolean;
  closePharmNHIS: boolean;
  hospitalFee: boolean;
  labWork: number;
  hasNHIS: number;
  careFacilities: number;
  doGetMedsFromAll: number;
  hasSpecialClinic: number;
  sameDoctor: number;
  drTellState: number;
  staffAdvise: number;
  runOutMeds: number;
  missAppointment: number;
  takeDrugsBeforeVisit: number;
  hospTime: number;
}

export interface IAnthropometries {
  demographyID: number;
  height: number;
  weight: number;
  bmi: number;
  mUAC: number;
  abdCirc: number;
  systole: number;
  diastole: number;
}

export interface IBpHistory {
  demographyID: number;
  systole: number;
  diastole: number;
  dateChecked: Date;
}

export interface ICharts {
  chartsID: number;
  demographyID: number;
  comorbidity: string;
  medication: string;
}

export interface ILabs {
  demographyID: number;
  cholesterol: number;
  hdl: number;
  ldl: number;
  trigly: number;
  bun: number;
  creat: number;
  physicianDocs: number;
  followUp: boolean;
}

export interface IQualityAssessments {
  demographyID: number;
  healthScale: number;
  compared: number;
  vigorous: number;
  moderate: number;
  climbing: number;
  bending: number;
  walkingMile: number;
  walkingBlocks: number;
  walkingOne: number;
  bathingSelf: number;
  cutDown: number;
  accomplishLess: number;
  wereLimited: number;
  hadDiff: number;
  cutDownEm: number;
  accomplishEm: number;
  wasCareful: number;
  emotionInterfere: number;
  bodyPainIn4: number;
  bodyPainInHouse: number;
  hasPep: number;
  isNervous: number;
  isDump: number;
  wasPeaceful: number;
  hasEnergy: number;
  wasDownhearted: number;
  wasWornOut: number;
  beenHappy: number;
  feelTired: number;
  socialInterfere: number;
  sickEasier: number;
  veryHealthy: number;
  toGetWorse: number;
  isExcellent: number;
}

export interface ISocioFactors {
  demographyID: number;
  financeDiffs: boolean;
  hasConcerns: boolean;
  concerns: string;
  hasAssitance: boolean;
  takesHerbal: number;
  stillHerbal: number;
  herbReason: string;
  seenDietician: number;
  believeDiet: number;
  specialDiet: number;
  physicalActivity: boolean;
  walking: boolean;
  running: boolean;
  others: string;
  oftenPhysical: number;
  timePhysical:number
  cigarette: boolean;
  howLongCig: number;
  numberPerDay: number;
  currentDrink: boolean;
  everDrunk: boolean;
  howLongAlc: number;
  unitsPerWeek: number;
  isRiskStroke: boolean;
  isRiskHeartAttack: boolean;
  isRiskDiabetes: boolean;
  isRiskBlind: boolean;
  isRiskKidney: boolean;
  dieEarly: boolean;
  feelSad: boolean;
  doctorWish: string;
};
