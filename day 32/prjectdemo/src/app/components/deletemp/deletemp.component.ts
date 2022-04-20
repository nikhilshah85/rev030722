import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-deletemp',
  templateUrl: './deletemp.component.html',
  styleUrls: ['./deletemp.component.css']
})
export class DeletempComponent implements OnInit {

  _empSer:EmployeeService;
  delteOperationMessage:any ="";
  constructor(_empSerRef:EmployeeService) 
  {
    this._empSer = _empSerRef;
   }


   delteEmpById(eno:any)
   {
     this._empSer.deleteEmployeeById(eno).subscribe( (data)=>{
        this.delteOperationMessage =data 
        console.log(data);
      },(errdetails)=>{
        this.delteOperationMessage = errdetails;
        console.log(errdetails);
      })
   }
  ngOnInit(): void {
  }

}
