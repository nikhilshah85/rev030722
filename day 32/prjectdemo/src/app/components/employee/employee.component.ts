import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {


  _empService:EmployeeService;
  allEmployee:any = [];
  constructor(_empServiceRef:EmployeeService)
  {
    this._empService = _empServiceRef;
  }

  showAllEmployee()
  {
      this._empService.getAllEmployees().subscribe( (data)=>{
        this.allEmployee = data;
        console.log(this.allEmployee);
      })
  }




  ngOnInit(): void {
  }

}
