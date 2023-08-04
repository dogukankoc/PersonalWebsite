import { Component } from '@angular/core';
import { NgModule, OnInit } from '@angular/core';
import { ProjectModel } from '../../../core/models/project.model';
import { ProjectService } from '../../../core/services/project.service';
import { CreateProjectModel } from 'src/app/core/models/createproject.model';
declare var $: any

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss']
})
export class ProjectComponent implements OnInit {
  projectList: ProjectModel[];
  project:ProjectModel;
  createProjectModel:CreateProjectModel;
  createProjectList: CreateProjectModel[];
  
  constructor(private projectService: ProjectService) { }
 
  ngOnInit() {
    $(document).ready(function () {
    }) == this.GetAll();
  }
  GetAll() {
     return this.projectService.GetAll().subscribe((response: ProjectModel[]) => this.projectList = response);
  }
  
  ProjectAdd(userId: HTMLInputElement, name: HTMLInputElement, detail: HTMLInputElement, imagePath: HTMLInputElement) {
    alert(userId.value + " " + name.value + " " + detail.value + " " + imagePath.value);
 
    let postProject: CreateProjectModel = {
      userId: userId.valueAsNumber,
      name: name.value,
      detail: detail.value,
      imagePath: imagePath.value,
    };
    this.projectService.ProjectAdd(postProject).subscribe((response: CreateProjectModel) => {
      if (response) {
        this.createProjectList.unshift(response);
        this.createProjectModel = response;
      }
    });
}
}