import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SleepPageComponent } from './sleep-page.component';

describe('SleepPageComponent', () => {
  let component: SleepPageComponent;
  let fixture: ComponentFixture<SleepPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SleepPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SleepPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
