import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./contest-entry-form.component.html"),
    styles: [require("./contest-entry-form.component.scss")],
    selector: "h-contest-entry-form",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ContestEntryFormComponent implements OnInit { 
    ngOnInit() {

    }
}
