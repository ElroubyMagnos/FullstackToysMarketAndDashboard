import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CallusComponent } from './callus.component';

describe('CallusComponent', () => {
  let component: CallusComponent;
  let fixture: ComponentFixture<CallusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CallusComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CallusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
