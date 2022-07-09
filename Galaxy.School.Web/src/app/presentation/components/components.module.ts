import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseFormComponent } from './course/course-form/course-form.component';
import { CourseTableComponent } from './course/course-table/course-table.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { SidebarComponent } from './shared/sidebar/sidebar.component';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [
    // Course
    CourseFormComponent,
    CourseTableComponent,
    // Shared
    NavbarComponent,
    SidebarComponent,
  ],
  imports: [CommonModule, SharedModule],
  exports: [NavbarComponent],
})
export class ComponentsModule {}
