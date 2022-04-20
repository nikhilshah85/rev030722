import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletempComponent } from './deletemp.component';

describe('DeletempComponent', () => {
  let component: DeletempComponent;
  let fixture: ComponentFixture<DeletempComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeletempComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeletempComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
