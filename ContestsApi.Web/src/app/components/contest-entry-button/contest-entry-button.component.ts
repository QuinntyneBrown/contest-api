import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./contest-entry-button.component.html"),
    styles: [require("./contest-entry-button.component.scss")],
    selector: "contest-entry-button",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ContestEntryButtonComponent implements OnInit { 
    ngOnInit() {

    }
}
