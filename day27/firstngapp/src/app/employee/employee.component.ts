import { Component, Pipe } from "@angular/core";


@Component({
    selector:'emp',
    templateUrl:'./employee.component.html',
    styleUrls:['./employee.component.css']
})
export class Employee
{
    empNo = 101;
    empName = "Mike";
    empLastName = "Hussey";
    empDesignation = "Sales";
    
    empInfo(){
        return this.empNo + " : " + this.empName + ' ' + this.empLastName   + ' works as ' + this.empDesignation; 
    }


}