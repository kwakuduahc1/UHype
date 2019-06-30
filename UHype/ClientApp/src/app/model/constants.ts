
export const facilities = ['Kumasi South', 'Tech Hospital', 'Komfo Anokye'];

export const teams = ['Alpha', 'Beta', 'Theta', 'Omega', 'Pi', 'Gamma', 'Delta', 'Kappa', 'Zigma'];

export interface IKeyValuePairs {
  value: number | boolean;
  label: string;
}

export const sections: Array<{ section: number, state: boolean, label: string }> = [
  { section: 1, state: true, label: "Demographic Information" },
  { section: 2, state: false, label: "Hypertension, Co-morbidities and Medications" },
  { section: 3, state: false, label: "Social factors and beliefs" },
  { section: 4, state: false, label: "Health related quality assessment of life" },
  { section: 5, state: false, label: "Anthropometry" },
  { section: 7, state: false, label: "Labs and others" }]

export const gender: IKeyValuePairs[] = [{ value: 0, label: "Female" }, { value: 1, label: "Male" }];
export const educations: IKeyValuePairs[] = [
  { value: 0, label: "None" },
  { value: 1, label: "Primary School" },
  { value: 2, label: "JHS" },
  { value: 3, label: "SHS" },
  { value: 4, label: "College 3 years" },
  { value: 5, label: "College 4 years" },
  { value: 6, label: "College 6 years and beyond" },
  { value: 7, label: "Polytechnic" }]

export const occupation: IKeyValuePairs[] = [
  { value: 0, label: "Farming" },
  { value: 1, label: "Wage earner" },
  { value: 2, label: "Farm laborer" },
  { value: 3, label: "Bicycle repairer" },
  { value: 5, label: "Mechanic / Motor Vehicle Repairer" },
  { value: 6, label: "Driver" },
  { value: 7, label: "Carpenter" },
  { value: 8, label: "Construction" },
  { value: 9, label: "Masonry" },
  { value: 10, label: "Transport business" },
  { value: 11, label: "Butcher" },
  { value: 12, label: "Tailor/Seamstress" },
  { value: 13, label: "Trader" },
  { value: 14, label: "Others" },
  { value: 15, label: "Unemployed" },
  { value: 4, label: "Retiree" }
]

export const maritalStatuses: IKeyValuePairs[] = [
  { value: 1, label: "Single" },
  { value: 2, label: "Married" },
  { value: 3, label: "Separated" },
  { value: 4, label: "Co - habiting" },
  { value: 5, label: "Widowed" }];

export const ethnics: IKeyValuePairs[] = [
  { value: 1, label: "Ashanti" },
  { value: 2, label: "Akyem" },
  { value: 3, label: "Fante" },
  { value: 4, label: "Bono" },
  { value: 5, label: "Akuapem" },
  { value: 6, label: "Kwahu" },
  { value: 7, label: "Kotokoli" },
  { value: 8, label: "Dagomba" },
  { value: 9, label: "Dagati" },
  { value: 10, label: "Kokomba" },
  { value: 11, label: "Gonja" },
  { value: 12, label: "Ewe" },
  { value: 13, label: "Gruma" },
  { value: 14, label: "Fulani" },
  { value: 15, label: "Kusasi" },
  { value: 16, label: "Frafra" },
  { value: 17, label: "Mossi" },
  { value: 19, label: "Not Ghanaian" },
  { value: 18, label: "Other" }
];

export const religions: IKeyValuePairs[] = [{ label: "Christian", value: 1 },
{ label: "Muslim", value: 2 },
{ label: "Animism/African Traditional Religion", value: 3 },
{ label: "Atheist", value: 4 },
{ label: "Others", value: 5 }];

export const knows: IKeyValuePairs[] = [
  { value: 1, label: "Screening program" },
  { value: 2, label: "Visit to the clinic" },
  { value: 3, label: "At the pharmacy store" },
  { value: 4, label: "I do not remember" },
  { value: 5, label: "Others" }]

export const tripples: IKeyValuePairs[] = [{ value: 0, label: "No" }, { value: 1, label: "Yes" }, { value: 3, label: "Don't know" }];

export const cares: IKeyValuePairs[] = [
  { value: 3, label: "All the time" },
  { value: 2, label: "Most of the time" },
  { value: 1, label: "Half the time" },
  { value: 0, label: "Never" }
];

export const yesNos: IKeyValuePairs[] = [
  { value: true, label: "Yes" }, { value: false, label: "No" }];

export const limits: IKeyValuePairs[] = [{ value: 2, label: "Yes, limits a lot" }, { value: 1, label: "Yes, limited a little" }, { value: 0, label: "No, not limited at all" }];

export const levels: IKeyValuePairs[] = [{ value: 0, label: "None/Not at all" }, { value: 1, label: "Slightly/Little bit" }, { value: 2, label: "Moderately" }, { value: 3, label: "Severe/Quite a bit" }, { value: 4, label: "Very severe/Extremely" }];

export const energies: IKeyValuePairs[] = [
  { value: 5, label: "All of the time" },
  { value: 4, label: "Most of the time" },
  { value: 3, label: "A good bit of the time" },
  { value: 2, label: "Some of the time" },
  { value: 1, label: "A little bit of the time" },
  { value: 0, label: "None of the time" }
];

export const eae: Array<{ control: string, label: string }> = [
  { control: 'hasPed', label: 'Did you feel full of pep?' },
  { control: 'isNervous', label: 'Have you been a very nervous person?' },
  { control: 'isDump', label: 'Have you felt so down in the dumps that nothing could cheer you up?' },
  { control: 'wasPeaceful', label: 'Have you felt calm and peaceful?' },
  { control: 'hasEnergy', label: 'Did you have a lot of energy?' },
  { control: 'wasDownhearted', label: 'Have you felt downhearted and blue?' },
  { control: 'wasWornOut', label: 'Did you feel worn out?' },
  { control: 'beenHappy', label: 'Have you been a happy person?' },
  { control: 'feelTired', label: 'Did you feel tired?' },
  { control: 'socialInterfere', label: 'My physical health has interfered in my social life' }
]
export const healthies: IKeyValuePairs[] = [
  { value: 5, label: "Definitely true" },
  { value: 4, label: "Mostly true" },
  { value: 3, label: "Don't know" },
  { value: 2, label: "Mostly false" },
  { value: 1, label: "Definitely false" }
];

export const heaqts: Array<{ control: string, label: string }> = [
  { control: 'sickEasier', label: 'I seem to get sick easier than other people' },
  { control: 'veryHealthy', label: 'I am as healthy as anybody I know' },
  { control: 'toGetWorse', label: ' I expect my health to get worse' },
  { control: 'isExcellent', label: 'My health is excellent ' }
]
export const healthScale: IKeyValuePairs[] = [
  { value: 5, label: 'Excellent' }, { value: 4, label: 'Very Good' }, { value: 3, label: 'Good' }, { value: 2, label: 'Fair' }, { value: 1, label: 'Poor' }]
export const bpControls: IKeyValuePairs[] = [
  { value: 2, label: "Controlled " },
  { value: 1, label: "Uncontrolled " },
  { value: 0, label: "None" }
];

export const drugSrcs: IKeyValuePairs[] = [
  { value: 1, label: "All given at the hospital with NHIS" },
  { value: 2, label: "Some at the hospital and the rest at a close - by pharmacy with NHIS" },
  { value: 3, label: "Some at the hospital, others at a close by pharmacy and the rest purchased later" },
  { value: 4, label: "All at a close - by pharmacy with NHIS" },
  { value: 5, label: "All purchased at the hospital" }
]

export interface ILickert extends IKeyValuePairs {
  control: string
}


export const twoYearsCare: Array<{ control: string, label: string }> = [
  { control: 'sameDoctor', label: "How often do you see the same doctor" },
  {
    control: 'drTellState', label: "How often does your doctor tell you about the state of your BP"
  },
  {
    control: "staffAdvise", label: "How often do you get advice from health care staff regarding means to bring down your BP"
  },
  {
    control: "runOutMeds", label: "How often do you run out of your BP medications before a follow up visit"
  },
  { control: "missAppointment", label: "How often do you miss an appointment" },
  {
    control: "hospTime", label: "How often do you take your drugs before coming to the clinic for a follow up"
  },
  { control: "takeDrugsBeforeVisit", label: "Do you get to the hospital on time for typical hypertension follow up" }
]

export const yearCompare: IKeyValuePairs[] = [
  { value: 5, label: 'Much better now than one year ago' },
  { value: 4, label: 'Somewhat better now than one year ago' },
  { value: 3, label: 'About the same' },
  { value: 2, label: 'Somewhat worse now than one year ago' },
  { value: 1, label: 'Much worse than one year ago' },
]

export const actLimits: Array<{ control: string, label: string }> = [
  { control: 'vigorous', label: "Vigorous activities, such as running, lifting heavy objects, participating in strenuous sports" },
  {
    control: 'moderate', label: "Moderate activities, such as moving a table, lifting or carrying groceries"
  },
  {
    control: "climbing", label: "Climbing one flight of stairs"
  },
  {
    control: "bending", label: "Bending, kneeling, or stooping"
  },
  { control: "walkingMile", label: "Walking more than a mile" },
  {
    control: "walkingBlocks", label: "Walking several blocks"
  },
  {
    control: "walkingOne", label: "Walking one block"
  },
  { control: "bathingSelf", label: "Bathing or dressing yourself" }
]

export const phyLimits: Array<{ control: string, label: string }> = [
  { control: 'cutDown', label: "Cut down the amount of time you spent on work or other activities  strenuous sports" },
  {
    control: 'accomplishLess', label: "Accomplished less than you would like"
  },
  {
    control: "wereLimited", label: "Were limited in the kind of work or other activities"
  },
  {
    control: "hadDiff", label: "Had difficulty performing the work or other activities(for example, it took extra effort)"
  }
]

export const emLimits: Array<{ control: string, label: string }> = [
  { control: 'cutDown', label: "Cut down the amount of time you spent on work or other activities" },
  {
    control: 'accomplishEm', label: "Accomplished less than you would like"
  },
  {
    control: "wasCareful", label: "Didn't do work or other activities as carefully as usual"
  }
]
