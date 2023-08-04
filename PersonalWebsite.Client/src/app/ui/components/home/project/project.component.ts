import { Component } from '@angular/core';
import { NgModule, OnInit } from '@angular/core';
import { ProjectModel } from '../../../../core/models/project.model';
import { ProjectService } from '../../../../core/services/project.service';
declare var $: any

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss']
})
export class ProjectComponent implements OnInit {
  projectList: ProjectModel[];
  
  constructor(private projectService: ProjectService) { }
 
  ngOnInit() {
    $(document).ready(function () {
    }) == this.GetLastProjectsByNumber(3);
  }
  GetLastProjectsByNumber(lastProjects:number) {
     return this.projectService.GetLastProjectsByNumber(lastProjects).subscribe((response: ProjectModel[]) => this.projectList = response);
  }}
  