import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable()
export class BlogService {
 
  constructor(private httpClient: HttpClient, @Inject("url") private url: string) { }
 
  GetAll() {
    return this.httpClient.get(this.url + "api/blogs");
  }
  GetLastBlogsByNumber(lastBlogs: number) {
    return this.httpClient.get(this.url + "api/blogs/lastblogs/" + lastBlogs);
  }
}