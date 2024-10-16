import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class DataServiceService {
  constructor(
    @Inject(String) private apiUrl : string,
    private http : HttpClient
  ) { }

  public getAllData = <T>() : Observable<T> => {
    return this.http
    .get<T>(`${this.apiUrl}`, {
      headers: { 
        'content-type': 'application/json'
      }
    })
    .pipe(
      catchError(this.handleError)
    )
  }

  public getOneData = <T>(id: number) : Observable<T> => {
    return this.http
    .get<T>(`${this.apiUrl}/${id}`)
    .pipe(
      catchError(this.handleError)
    )
  }

  public createOneData = <T>(userData : T) : Observable<any> => {
    return this.http
    .post<any>(`${this.apiUrl}`, userData)
    .pipe(
      catchError(this.handleError)
    )
  }

  public updateOneData = <T>(id : number, userData : T) : Observable<T> => {
    return this.http
    .put<T>(`${this.apiUrl}/${id}`, userData)
    .pipe(
      catchError(this.handleError)
    )
  }

  public deleteOneData = <T>(id : number) : Observable<T> => {
    return this.http
    .delete<T>(`${this.apiUrl}/${id}`)
    .pipe(
      catchError(this.handleError)
    )
  }

  private handleError(error: unknown) {
    if (error instanceof HttpErrorResponse) {
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    } else if (error instanceof ErrorEvent) {
      console.error('An error occurred:', error.message);
    } else if (typeof error === 'string') {
      console.error('Error string:', error);
    } else {
      console.error('An unknown error occurred:', error);
    }
    return throwError(() =>
      new Error('Something bad happened; please try again later.')
    );
  }
}
