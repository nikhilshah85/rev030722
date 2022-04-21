import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnnounceeventComponent } from './announceevent.component';

describe('AnnounceeventComponent', () => {
  let component: AnnounceeventComponent;
  let fixture: ComponentFixture<AnnounceeventComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnnounceeventComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AnnounceeventComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
