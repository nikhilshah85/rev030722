import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientreportComponent } from './clientreport.component';

describe('ClientreportComponent', () => {
  let component: ClientreportComponent;
  let fixture: ComponentFixture<ClientreportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientreportComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientreportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
