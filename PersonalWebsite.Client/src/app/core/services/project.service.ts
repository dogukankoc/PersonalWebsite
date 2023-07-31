import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {ProjectModel} from '../models/project.model' 
@Injectable()
export class ProjectService {
 
  constructor(private httpClient: HttpClient, @Inject("url") private url: string) { }
 
  GetAll() {
    return this.httpClient.get(this.url + "api/projects");
  }
  // GetSingle(id: number) {
  //   return this.httpClient.get(this.url + "api/personel/getsingle/" + id);
  // }
  // PostAdd(personel: Personel) {
  //   return this.httpClient.post(this.url + "api/personel/postadd", personel);
  // }
  // PutUpdate(personel: Personel) {
  //   return this.httpClient.put(this.url + "api/personel/putupdate", personel);
  // }
  // Remove(id: number) {
  //   return this.httpClient.delete(this.url + "api/personel/remove/" + id);
  // }

}