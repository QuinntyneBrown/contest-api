import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./dropdown.component.html"),
    styles: [require("./dropdown.component.scss")],
    selector: "dropdown",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class DropdownComponent implements OnInit { 
    ngOnInit() {

    }
}
