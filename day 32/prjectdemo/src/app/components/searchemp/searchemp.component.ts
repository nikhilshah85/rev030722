import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-searchemp',
  templateUrl: './searchemp.component.html',
  styleUrls: ['./searchemp.component.css']
})
export class SearchempComponent implements OnInit {


  _empService:EmployeeService;
  empDetail:any;

  constructor(_empServiceRef:EmployeeService) {
    this._empService = _empServiceRef;
   }

   searchEmployeeById(emp:any)
   {
    this._empService.getEmployeeById(emp).subscribe( (data)=>{
      this.empDetail = data;
      console.log(this.empDetail);
    })
   }

  ngOnInit(): void {
  }

}
