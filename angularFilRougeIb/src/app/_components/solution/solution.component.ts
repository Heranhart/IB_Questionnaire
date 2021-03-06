import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

import { Solution } from 'src/app/_models/solution';

@Component({
  selector: 'app-solution',
  templateUrl: './solution.component.html',
  styleUrls: ['./solution.component.css']
})
export class SolutionComponent implements OnInit {

  @Input() solution : Solution;
  @Output() repSend = new EventEmitter<any>();

  isChecked:boolean=false;
  constructor() { }

  ngOnInit(): void {
  }

  changement(e){
      this.repSend.emit(this.solution.idSolution)
    }
    // console.log(this.solution.solution,this.isChecked)
  // }
  
}
