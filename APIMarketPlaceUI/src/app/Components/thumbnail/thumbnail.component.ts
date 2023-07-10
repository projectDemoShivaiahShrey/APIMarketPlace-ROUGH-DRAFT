import { Component, OnInit } from '@angular/core';
import { ThumbnailService } from 'src/app/Services/thumbnail.service';
import { Api } from 'src/app/Models/Api';

@Component({
  selector: 'app-thumbnail',
  templateUrl: './thumbnail.component.html',
  styleUrls: ['./thumbnail.component.scss']
})
export class ThumbnailComponent {
    api = new Api();
    constructor(private thumbnailService : ThumbnailService) {}
    ngOnInit() : void {
      this.thumbnailService.getApiInfo().subscribe((result : Api) => (this.api = result));
    }

}
