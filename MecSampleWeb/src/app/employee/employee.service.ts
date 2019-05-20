import {Injectable} from '@angular/core';
import {IEmployee} from './employee';
import {Http,Response} from '@angular/http';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';
@Injectable()
export class EmployeeService{

  constructor(private _http:Http){}  
  getEmployees():Observable<IEmployee[]>{
      return this._http.get("http://localhost:52008/api/employee").pipe(map((response: Response) => <IEmployee[]>response.json()));
    //return[];
   

  }
}