import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employee';
import {EmployeeService} from './employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css'],
  providers:[EmployeeService]
})
export class EmployeeComponent implements OnInit {
welcome:string;
employees:IEmployee[];

  constructor(private _employeeService:EmployeeService){}

  ngOnInit() {
     this._employeeService.getEmployees()
                                .subscribe((employeeData)=>this.employees = employeeData);
  }

}
