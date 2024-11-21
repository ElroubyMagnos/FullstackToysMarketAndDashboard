import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryshowComponent } from './categoryshow.component';

describe('CategoryshowComponent', () => {
  let component: CategoryshowComponent;
  let fixture: ComponentFixture<CategoryshowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CategoryshowComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CategoryshowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
