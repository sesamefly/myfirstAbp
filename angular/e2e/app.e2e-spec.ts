import { MyFirstABPTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: MyFirstABPTemplatePage;

  beforeEach(() => {
    page = new MyFirstABPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
