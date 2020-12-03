import { ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

import { DashboardComponent } from './dashboard.component';
import { RouterTestingModule } from '@angular/router/testing';
import { DebugElement } from '@angular/core';
import { By } from '@angular/platform-browser';

describe('DashboardComponent', () => {
  let component: DashboardComponent;
  let fixture: ComponentFixture<DashboardComponent>;
  let de : DebugElement;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule,RouterTestingModule], 
      declarations: [ DashboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardComponent);
    component = fixture.componentInstance;
    de = fixture.debugElement;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have animal thats not null', () => {
    expect(component.animal).not.toBeNull();
  });

  it('should call the Play function when the Play button is clicked', fakeAsync (() => {
    spyOn(component, 'Play');

    let button = de.nativeElement.querySelector('#button_2');
    button.click();
    tick();
    expect(component.Play).toHaveBeenCalled();
    
  }));

  it('should call the Sleep function when the Sleep button is clicked', fakeAsync (() => {
    spyOn(component, 'Sleep');

    let button = de.nativeElement.querySelector('#button_3');
    button.click();
    tick();
    expect(component.Sleep).toHaveBeenCalled();
    
  }));

  it('should call the Shop function when the Shop button is clicked', fakeAsync (() => {
    spyOn(component, 'Shop');

    let button = de.nativeElement.querySelector('#button_4');
    button.click();
    tick();
    expect(component.Shop).toHaveBeenCalled();
    
  }));

});
