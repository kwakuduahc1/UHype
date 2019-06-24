import { Injectable } from "@angular/core";
import { IDemography, ISecondSections, IAnthropometries, IBpHistory, ICharts, ILabs, IQualityAssessments, ISocioFactors } from "../model/dtos";

@Injectable({ providedIn: 'root' })
export class DataProvider {
  data: {
    demo: IDemography,
    sec: ISecondSections,
    ant: IAnthropometries,
    vit: IBpHistory,
    chart: ICharts,
    lab: ILabs,
    ass: IQualityAssessments,
    soc: ISocioFactors
  };

  constructor() {
    this.data.demo = {} as IDemography;
    this.data.sec = {} as ISecondSections;
    this.data.ant = {} as IAnthropometries;
    this.data.vit = {} as IBpHistory;
    this.data.chart = {} as ICharts;
    this.data.lab = {} as ILabs;
    this.data.ass = {} as IQualityAssessments;
    this.data.soc = {} as ISocioFactors;
  }
}
