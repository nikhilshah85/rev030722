import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchempComponent } from './searchemp.component';

describe('SearchempComponent', () => {
  let component: SearchempComponent;
  let fixture: ComponentFixture<SearchempComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchempComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchempComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
