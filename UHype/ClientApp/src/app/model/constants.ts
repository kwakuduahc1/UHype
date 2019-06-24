
export const facilities = ['Kumasi South', 'Tech Hospital', 'Komfo Anokye'];

export const teams = ['Alpha', 'Beta', 'Theta', 'Omega', 'Pi', 'Gamma', 'Delta', 'Kappa', 'Zigma'];

export interface IKeyValuePairs {
  value: number | boolean;
  label: string;
}
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

export const Ethnics: IKeyValuePairs[] = [
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

export const healthies: IKeyValuePairs[] = [
  { value: 5, label: "Definitely true" },
  { value: 4, label: "Mostly true" },
  { value: 3, label: "Don't know" },
  { value: 2, label: "Mostly false" },
  { value: 1, label: "Definitely false" }
];

export const bpControls: IKeyValuePairs[] = [
  { value: 2, label: "Controlled " },
  { value: 1, label: "Uncontrolled " },
  { value: 0, label: "None" }
];
