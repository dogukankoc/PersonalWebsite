import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { ProjectModel } from '../models/project.model';
import { CreateProjectModel } from '../models/createproject.model';

@Injectable()
export class ProjectService {
 
  constructor(private httpClient: HttpClient, @Inject("url") private url: string) { }
 
  GetAll() {
    return this.httpClient.get(this.url + "api/projects");
  }
  GetLastProjectsByNumber(lastProjects: number) {
    return this.httpClient.get(this.url + "api/projects/lastprojects/" + lastProjects);
  }

  ProjectAdd(createProject: CreateProjectModel) {
    return this.httpClient.post(this.url + "api/projects/", createProject);
  }

}