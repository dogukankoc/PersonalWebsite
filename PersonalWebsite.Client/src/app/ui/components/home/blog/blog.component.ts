import { Component } from '@angular/core';
import { NgModule, OnInit } from '@angular/core';
import { BlogModel } from '../../../../core/models/blog.model';
import { BlogService } from '../../../../core/services/blog.service';
declare var $: any

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.scss']
})
export class BlogComponent implements OnInit {
  blogList: BlogModel[];
  
  constructor(private blogService: BlogService) { }
 
  ngOnInit() {
    $(document).ready(function () {
    }) == this.GetLastBlogsByNumber(3);
  }
  GetLastBlogsByNumber(lastBlogs:number) {
     return this.blogService.GetLastBlogsByNumber(lastBlogs).subscribe((response: BlogModel[]) => this.blogList = response);
  }}
  