import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Message } from '../../models/message';

@Component({
  selector: 'app-floatingchat',
  templateUrl: './floatingchat.component.html',
  styleUrl: './floatingchat.component.css'
})
export class FloatingchatComponent {
  ChatShow: boolean = false;
  ChatCount: number = 0;
  CurrentMessages: Message[] = [];
  UnseenFromPanel: number = 0;

  IntervalSafe: boolean = false;
  constructor(private http: HttpClient)
  {
    setInterval(() => 
    {
       this.http.get<number>(`/Chat/UnseenMsgsByCustomerCount/`)
       .subscribe(x => this.UnseenFromPanel = x);
    }, 3000)

    setInterval(() => 
    {
      if (this.ChatShow)
      {
        this.http.get(`/Chat/SeenPanelMsgs/`)
        .subscribe();
      }
    }, 5000);

    setInterval(() => 
    {
      if (this.IntervalSafe)
        return;

      this.IntervalSafe = true;

      this.http.get<number>(`/Chat/CheckChatCount/`)
      .subscribe(x => 
      {
        this.IntervalSafe = false;

        if (x != this.ChatCount)
        {
          this.http.get<Message[]>(`/Chat/GetTopChats/`)
          .subscribe(x => this.CurrentMessages = x);

          this.ChatCount = x;
          
          if (this.UnseenFromPanel != 0)
          {
            var MsgTick = new Audio('/chateffect.wav');
            MsgTick.play();
          } 
        }
      });
    }, 3000);
  }

  SendPrivateMsg(f: NgForm, ta: HTMLDivElement)
  {
    this.http.get<boolean>(`/Chat/SendPrivMsg/${f.value.Message}/`)
    .subscribe(x => {f.reset(); ta.scrollTo(0, ta.scrollHeight);});
  }
}
