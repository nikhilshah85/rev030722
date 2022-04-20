import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrganizatioonComponent } from './organizatioon.component';

describe('OrganizatioonComponent', () => {
  let component: OrganizatioonComponent;
  let fixture: ComponentFixture<OrganizatioonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrganizatioonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OrganizatioonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
