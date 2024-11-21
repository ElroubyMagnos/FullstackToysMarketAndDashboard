import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FloatingchatComponent } from './floatingchat.component';

describe('FloatingchatComponent', () => {
  let component: FloatingchatComponent;
  let fixture: ComponentFixture<FloatingchatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FloatingchatComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FloatingchatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
