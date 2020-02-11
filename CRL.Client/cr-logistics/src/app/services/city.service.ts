import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CityModel } from '../models/city.model';

@Injectable({
  providedIn: 'root'
})
export class CityService {

  constructor(private http: HttpClient) { }

  getCities(): Observable<CityModel[]> {
    return this.http.get<CityModel[]>(environment.webApi + "city/all");
  }
  getCitiesByName(name: string): Observable<CityModel[]> {
    return this.http.get<CityModel[]>(environment.webApi + "city/byName/"+name);
  }
  addCity(city: CityModel) {
    return this.http.post(environment.webApi + "city", city);
  }
  findLogisticCenter(): Observable<CityModel> {
    return this.http.get<CityModel>(environment.webApi + "city/LogisticCenter");
  }
}
