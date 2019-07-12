import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-iframe',
  templateUrl: './iframe.component.html',
  styleUrls: ['./iframe.component.css']
})
export class IframeComponent  extends AppComponentBase implements OnInit{

  constructor(injector: Injector) {
    super(injector)
   }

  ngOnInit() {
  }

}
