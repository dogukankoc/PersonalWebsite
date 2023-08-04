import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable()
export class ProjectService {
 
  constructor(private httpClient: HttpClient, @Inject("url") private url: string) { }
 
  GetAll() {
    return this.httpClient.get(this.url + "api/projects");
  }
  GetLastProjectsByNumber(lastProjects: number) {
    return this.httpClient.get(this.url + "api/projects/lastprojects/" + lastProjects);
  }

}