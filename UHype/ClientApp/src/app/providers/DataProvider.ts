import { Injectable } from "@angular/core";
import { IDemography, ISecondSections, IAnthropometries, IBpHistory, ICharts, ILabs, IQualityAssessments, ISocioFactors } from "../model/dtos";

@Injectable({ providedIn: 'root' })
export class DataProvider {
  data: { demography: IDemography } = {
    demography: {} as IDemography
  } 
  constructor() {
  }
}
