import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancereportComponent } from './financereport.component';

describe('FinancereportComponent', () => {
  let component: FinancereportComponent;
  let fixture: ComponentFixture<FinancereportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FinancereportComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancereportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
