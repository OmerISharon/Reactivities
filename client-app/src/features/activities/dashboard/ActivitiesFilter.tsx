import Calendar from 'react-calendar';
import { Header, Menu } from 'semantic-ui-react';

export default function ActivityFilters() {
    return (
        <>
        <Menu verical size='large' style={{width: '100%', marginTop: 28}}>
            <Header icon='filter' attached color='teal' content='Filter'>
                <Menu.Item content='All Activities' />
                <Menu.Item content="I'm going" />
                <Menu.Item content="I'm hosting" />
            </Header>
        </Menu>
        <Header /> 
        <Calendar />
        </>
    )
}